
namespace CachingMgt.Utility
{
    using CachingMgt.CustomException;
    using System;
    using System.Web;
    public static class SessionExtension
    {
        /// <summary>
        /// Set session state for given data for particular selected model information.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sessionStateBase"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetSessionData<T>(this HttpSessionStateBase sessionStateBase, string key, object value)
        {
            try
            {
                sessionStateBase[key] = (T)value;
            }
            catch (Exception ex)
            {
                throw new SessionException($"An error occured when retrieving the session data for {key}", ex);
            }
        }

        /// <summary>
        /// Get Session data for given key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sessionStateBase"></param>
        /// <param name="key"></param>
        /// <returns></returns>

        public static T GetSessionData<T>(this HttpSessionStateBase sessionStateBase, string key)
        {
            try
            {
                return (T)sessionStateBase[key];
            }
            catch (Exception ex)
            {
                throw new SessionException($"An error occured when retrieving the session data for {key}", ex);
            }
        }

    }
}