using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Discord.OAuth2
{
    /// <summary> Configuration options for <see cref="DiscordMiddleware"/>. </summary>
    public class DiscordOptions : OAuthOptions
    {
        /// <summary> Initializes a new <see cref="DiscordOptions"/>. </summary>
        public DiscordOptions()
        {
            AuthenticationScheme = DiscordDefaults.AuthenticationScheme;
            DisplayName = AuthenticationScheme;
            ClaimsIssuer = DiscordDefaults.Issuer;
            CallbackPath = DiscordDefaults.CallbackPath;
            AuthorizationEndpoint = DiscordDefaults.AuthorizationEndpoint;
            TokenEndpoint = DiscordDefaults.TokenEndpoint;
            UserInformationEndpoint = DiscordDefaults.UserInformationEndpoint;
        }
        
        /// <summary> Gets or sets the Discord-assigned appId. </summary>
        public string AppId { get { return ClientId; } set { ClientId = value; } }        
        /// <summary> Gets or sets the Discord-assigned app secret. </summary>
        public string AppSecret { get { return ClientSecret; } set { ClientSecret = value; } }
    }
}
