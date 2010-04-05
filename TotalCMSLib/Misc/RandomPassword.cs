using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;

namespace TotalCMS.Misc {
	/// <summary>
	/// A class that can be used to generate a random password.
	/// </summary>
	public sealed class RandomPassword {

		// Define default min and max password lengths.
		private static int DEFAULT_MIN_PASSWORD_LENGTH = 8;
		private static int DEFAULT_MAX_PASSWORD_LENGTH = 10;

		// Define supported password characters divided into groups.
		private static string PASSWORD_CHARS_LCASE = "abcdefgijkmnopqrstwxyz";
		private static string PASSWORD_CHARS_UCASE = "ABCDEFGHJKLMNPQRSTWXYZ";
		private static string PASSWORD_CHARS_NUMERIC = "23456789";
		//private static string PASSWORD_CHARS_SPECIAL= "*$-+?_&=!%{}/";

		// Define password format
		private static string PASSWORD_FORMAT_MD5 = "md5";

		/// <summary>
		/// A hash function, used for passing passwords to a database.
		/// </summary>
		/// <param name="xiPassword">The password to be hased.</param>
		/// <returns>The hashed password.</returns>
		public static string HashPassword(string xiPassword) {
			return FormsAuthentication.HashPasswordForStoringInConfigFile(xiPassword, PASSWORD_FORMAT_MD5);
		}

		/// <summary>
		/// Generates a random password.
		/// </summary>
		/// <returns>
		/// Randomly generated password.
		/// </returns>
		/// <remarks>
		/// The length of the generated password will be determined at
		/// random. It will be no shorter than the minimum default and
		/// no longer than maximum default.
		/// </remarks>
		public static string Generate() {
			return Generate(DEFAULT_MIN_PASSWORD_LENGTH,
				DEFAULT_MAX_PASSWORD_LENGTH);
		}

		/// <summary>
		/// Generates a random password of the exact length.
		/// </summary>
		/// <param name="length">
		/// Exact password length.
		/// </param>
		/// <returns>
		/// Randomly generated password.
		/// </returns>
		public static string Generate(int length) {
			return Generate(length, length);
		}

		/// <summary>
		/// Generates a random password.
		/// </summary>
		/// <param name="minLength">
		/// Minimum password length.
		/// </param>
		/// <param name="maxLength">
		/// Maximum password length.
		/// </param>
		/// <returns>
		/// Randomly generated password.
		/// </returns>
		/// <remarks>
		/// The length of the generated password will be determined at
		/// random and it will fall with the range determined by the
		/// function parameters.
		/// </remarks>
		public static string Generate(int minLength, int maxLength) {
			// Make sure that input parameters are valid.
			if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
				return null;

			// Create a local array containing supported password characters
			// grouped by types.
			char[][] charGroups = new char[][] 
		{
			PASSWORD_CHARS_LCASE.ToCharArray(),
			PASSWORD_CHARS_UCASE.ToCharArray(),
			PASSWORD_CHARS_NUMERIC.ToCharArray()
		};

			/*
					{
						PASSWORD_CHARS_LCASE.ToCharArray(),
						PASSWORD_CHARS_UCASE.ToCharArray(),
						PASSWORD_CHARS_NUMERIC.ToCharArray(),
						PASSWORD_CHARS_SPECIAL.ToCharArray()
					};
			*/

			// Use this array to track the number of unused characters in each
			// character group.
			int[] charsLeftInGroup = new int[charGroups.Length];

			// Initially, all characters in each group are not used.
			for (int i = 0; i < charsLeftInGroup.Length; i++)
				charsLeftInGroup[i] = charGroups[i].Length;

			// Use this array to track (iterate through) unused character groups.
			int[] leftGroupsOrder = new int[charGroups.Length];

			// Initially, all character groups are not used.
			for (int i = 0; i < leftGroupsOrder.Length; i++)
				leftGroupsOrder[i] = i;

			// Because we cannot use the default randomizer, which is based on the
			// current time (it will produce the same "random" number within a
			// second), we will use a random number generator to seed the
			// randomizer.

			// Use a 4-byte array to fill it with random bytes and convert it then
			// to an integer value.
			byte[] randomBytes = new byte[4];

			// Generate 4 random bytes.
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			rng.GetBytes(randomBytes);

			// Convert 4 bytes into a 32-bit integer value.
			int seed = (randomBytes[0] & 0x7f) << 24 |
				randomBytes[1] << 16 |
				randomBytes[2] << 8 |
				randomBytes[3];

			// Now, this is real randomization.
			Random random = new Random(seed);

			// This array will hold password characters.
			char[] password = null;

			// Allocate appropriate memory for the password.
			if (minLength < maxLength)
				password = new char[random.Next(minLength, maxLength + 1)];
			else
				password = new char[minLength];

			// Index of the next character to be added to password.
			int nextCharIdx;


			// Index of the next character group to be processed.
			int nextGroupIdx;

			// Index which will be used to track not processed character groups.
			int nextLeftGroupsOrderIdx;

			// Index of the last non-processed character in a group.
			int lastCharIdx;

			// Index of the last non-processed group. Initially, we will skip
			// special characters.
			int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

			// Generate password characters one at a time.
			for (int i = 0; i < password.Length; i++) {
				// If only one character group remained unprocessed, process it;
				// otherwise, pick a random character group from the unprocessed
				// group list.
				if (lastLeftGroupsOrderIdx == 0)
					nextLeftGroupsOrderIdx = 0;
				else
					nextLeftGroupsOrderIdx = random.Next(0,
						lastLeftGroupsOrderIdx);

				// Get the actual index of the character group, from which we will
				// pick the next character.
				nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];

				// Get the index of the last unprocessed characters in this group.
				lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

				// If only one unprocessed character is left, pick it; otherwise,
				// get a random character from the unused character list.
				if (lastCharIdx == 0)
					nextCharIdx = 0;
				else
					nextCharIdx = random.Next(0, lastCharIdx + 1);

				// Add this character to the password.
				password[i] = charGroups[nextGroupIdx][nextCharIdx];

				// If we processed the last character in this group, start over.
				if (lastCharIdx == 0)
					charsLeftInGroup[nextGroupIdx] =
						charGroups[nextGroupIdx].Length;
				// There are more unprocessed characters left.
				else {
					// Swap processed character with the last unprocessed character
					// so that we don't pick it until we process all characters in
					// this group.
					if (lastCharIdx != nextCharIdx) {
						char temp = charGroups[nextGroupIdx][lastCharIdx];
						charGroups[nextGroupIdx][lastCharIdx] =
							charGroups[nextGroupIdx][nextCharIdx];
						charGroups[nextGroupIdx][nextCharIdx] = temp;
					}
					// Decrement the number of unprocessed characters in
					// this group.
					charsLeftInGroup[nextGroupIdx]--;
				}

				// If we processed the last group, start all over.
				if (lastLeftGroupsOrderIdx == 0)
					lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
				// There are more unprocessed groups left.
				else {
					// Swap processed group with the last unprocessed group
					// so that we don't pick it until we process all groups.
					if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx) {
						int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
						leftGroupsOrder[lastLeftGroupsOrderIdx] =
							leftGroupsOrder[nextLeftGroupsOrderIdx];
						leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
					}
					// Decrement the number of unprocessed groups.
					lastLeftGroupsOrderIdx--;
				}
			}

			// Convert password characters into a string and return the result.
			return new string(password);
		}

		/// <summary>
		/// This function encrypts a string so that it can be decrypted later.
		/// </summary>
		/// <param name="toEncrypt">The string to encrypt</param>
		/// <param name="useHashing">MD5 hash the key before encrypting the string?</param>
		/// <returns>An encrpyted string that can be decrpyted using the same key.</returns>
		public static string Encrypt(string toEncrypt, bool useHashing) {
			byte[] keyArray;
			byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

			string key = Constants.SecurityKey;
			//System.Windows.Forms.MessageBox.Show(key);
			//If hashing use get hashcode regards to your key
			if (useHashing) {
				MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
				keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
				//Always release the resources and flush data
				// of the Cryptographic service provide. Best Practice

				hashmd5.Clear();
			}
			else
				keyArray = UTF8Encoding.UTF8.GetBytes(key);

			TripleDESCryptoServiceProvider tdes =
					 new TripleDESCryptoServiceProvider();
			//set the secret key for the tripleDES algorithm
			tdes.Key = keyArray;
			//mode of operation. there are other 4 modes.
			//We choose ECB(Electronic code Book)
			tdes.Mode = CipherMode.ECB;
			//padding mode(if any extra byte added)

			tdes.Padding = PaddingMode.PKCS7;

			ICryptoTransform cTransform = tdes.CreateEncryptor();
			//transform the specified region of bytes array to resultArray
			byte[] resultArray =
			  cTransform.TransformFinalBlock(toEncryptArray, 0,
			  toEncryptArray.Length);
			//Release resources held by TripleDes Encryptor
			tdes.Clear();
			//Return the encrypted data into unreadable string format
			return Convert.ToBase64String(resultArray, 0, resultArray.Length);
		}

		/// <summary>
		/// Decrypts a string that was encrypted using this classes encrpyt method.
		/// </summary>
		/// <param name="cipherString">The encrptyed string.</param>
		/// <param name="useHashing">MD5 hash the key before decrypting.</param>
		/// <returns>A decrptyed string.</returns>
		public static string Decrypt(string cipherString, bool useHashing) {
			byte[] keyArray;
			//get the byte code of the string
			
			byte[] toEncryptArray = new byte[1];
			try {
				toEncryptArray = Convert.FromBase64String(cipherString);
			}
			catch {
				return string.Empty;
			}

			//Get your key from config file to open the lock!
            string key = SiteSettings.Securitykey;

			if (useHashing) {
				//if hashing was used get the hash code with regards to your key
				MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
				keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
				//release any resource held by the MD5CryptoServiceProvider

				hashmd5.Clear();
			}
			else {
				//if hashing was not implemented get the byte code of the key
				keyArray = UTF8Encoding.UTF8.GetBytes(key);
			}

			TripleDESCryptoServiceProvider tdes =
						new TripleDESCryptoServiceProvider();
			//set the secret key for the tripleDES algorithm
			tdes.Key = keyArray;
			//mode of operation. there are other 4 modes. 
			//We choose ECB(Electronic code Book)

			tdes.Mode = CipherMode.ECB;
			//padding mode(if any extra byte added)
			tdes.Padding = PaddingMode.PKCS7;

			ICryptoTransform cTransform = tdes.CreateDecryptor();
			byte[] resultArray = cTransform.TransformFinalBlock(
								 toEncryptArray, 0, toEncryptArray.Length);
			//Release resources held by TripleDes Encryptor                
			tdes.Clear();
			//return the Clear decrypted TEXT
			return UTF8Encoding.UTF8.GetString(resultArray);
		}
	}
}
