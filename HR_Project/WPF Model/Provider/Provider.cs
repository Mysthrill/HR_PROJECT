using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF_Model.Provider
{
    class Provider : IProvider
    {
        #region Static

        private static ActionServiceClient Client { get; set; }
        private static string AccessToken { get; set; }
        private static string ClientTag { get; set; }

        /// <summary>
        /// Static constructor of provider.
        /// </summary>
        static Provider()
        {
            Client = new ActionServiceClient();

            // Gets client tag from app.config configuration file
            ClientTag = ConfigurationManager.AppSettings.Get("ClientTag");

            // Retrieve AccessToken as first step
            var request = PrepareRequest(new TokenRequest());

            var response = Client.GetToken(request);

            // Store access token for subsequent service calls.
            AccessToken = response.AccessToken;
        }

        /// <summary>
        /// Helper method. Adds RequestId, ClientTag, and AccessToken to all request types.
        /// </summary>
        /// <typeparam name="T">The request type.</typeparam>
        /// <param name="request">The request</param>
        /// <returns>Fully prepared request, ready to use.</returns>
        private static T PrepareRequest<T>(T request) where T : RequestBase
        {
            request.RequestId = Guid.NewGuid().ToString();  // Generates unique request id
            request.ClientTag = ClientTag;
            request.AccessToken = AccessToken;

            return request;
        }

        #endregion

        #region Login / Logout

        /// <summary>
        /// Logs in to the service.
        /// </summary>
        /// <param name="userName">User name.</param>
        /// <param name="password">Password.</param>
        public void Login(string userName, string password)
        {
            var request = PrepareRequest(new LoginRequest());
            request.UserName = userName;
            request.Password = password;

            var response = Client.Login(request);


            if (request.RequestId != response.CorrelationId)
                throw new ApplicationException("Login: RequestId and CorrelationId do not match.");

            if (response.Acknowledge != AcknowledgeType.Success)
                throw new ApplicationException(response.Message);
        }

        /// <summary>
        /// Logs out of the service.
        /// </summary>
        public void Logout()
        {
            var request = PrepareRequest(new LogoutRequest());

            var response = Client.Logout(request);


            if (request.RequestId != response.CorrelationId)
                throw new ApplicationException("Logout: RequestId and CorrelationId do not match.");

            if (response.Acknowledge != AcknowledgeType.Success)
                throw new ApplicationException(response.Message);
        }

        #endregion
    }
}
