﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common.Security
{
	public static class SecurityManager
	{
        public static string _securityToken = "Authorization";
        /// <summary>
        /// Generates a token to be used in API calls.
        /// The token is generated by hashing a message with a key, using HMAC SHA256.
        /// The message is: username:ip:userAgent:timeStamp
        /// The key is: password:ip:salt
        /// The resulting token is then concatenated with username:timeStamp and the result base64 encoded.
        /// 
        /// API calls may then be validated by:
        /// 1. Base64 decode the string, obtaining the token, username, and timeStamp.
        /// 2. Ensure the timestamp is not expired.
        /// 2. Lookup the user's password from the db (cached).
        /// 3. Hash the username:ip:userAgent:timeStamp with the key of password:salt to compute a token.
        /// 4. Compare the computed token with the one supplied and ensure they match.
        /// </summary>
        public static string GenerateToken(string userId, string username, string userAgent)
        {
            AuthModel authModel = new AuthModel()
            {
                UserAgent = userAgent,
                UserId = userId,
                UserName = username
            };
            string hash = JsonConvert.SerializeObject(authModel);
            return Security.Encrypt(hash);
        }

        public static string getUserId(string token)
        {
            try
            {
                AuthModel authModel = JsonConvert.DeserializeObject<AuthModel>(Security.Decrypt(token));
                return authModel.UserId;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getUserName(string token)
        {
            try
            {
                AuthModel authModel = JsonConvert.DeserializeObject<AuthModel>(Security.Decrypt(token));
                return authModel.UserName;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Checks if a token is valid.
        /// </summary>
        /// <param name="token">string - generated either by GenerateToken() or via client with cryptojs etc.</param>
        /// <param name="ip">string - IP address of client, passed in by RESTAuthenticate attribute on controller.</param>
        /// <param name="userAgent">string - user-agent of client, passed in by RESTAuthenticate attribute on controller.</param>
        /// <returns>bool</returns>
        public static bool IsTokenValid(string token, string userAgent)
        {
            bool result = false;

            try
            {
                // Base64 decode the string, obtaining the token:username:timeStamp.
                AuthModel authModel = JsonConvert.DeserializeObject<AuthModel>(Security.Decrypt(token));

                if (authModel != null)
                {
                    if (userAgent != authModel.UserAgent)
                        return false;

                    //EFUnitOfWork unitOfWork = new EFUnitOfWork();
                    //userRepository resUser = new userRepository(unitOfWork);
                    //result = resUser.GetEntityByUsername(userid, username);
                    result = true;
                }
            }
            catch
            {
            }

            return result;
        }
    }
}
