namespace ADB2CAuthorization
{
    public static class Constants
    {
        // set your tenant name, for example "contoso123tenant"
        static readonly string tenantName = "spottedmahnb2c";

        // set your tenant id, for example: "contoso123tenant.onmicrosoft.com"
        static readonly string tenantId = "spottedmahnb2c.onmicrosoft.com";

        // set your client/application id, for example: aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"
        static readonly string clientId = "3f748dfd-91ed-4b50-a41c-6ca5242a2043";

        // set your sign up/in policy name, for example: "B2C_1_signupsignin"
        static readonly string policySignin = "B2C_1_Mobile";

        // set your forgot password policy, for example: "B2C_1_passwordreset"
        static readonly string policyPassword = "<INSERT_PASSWORD_RESET_POLICY_NAME>";

        // set to a unique value for your app, such as your bundle identifier. Used on iOS to share keychain access.
        static readonly string iosKeychainSecurityGroup = "com.xamarin.adb2cauthorization";



        // The following fields and properties should not need to be changed
        static readonly string[] scopes = { "" };
        static readonly string authorityBase = $"https://{tenantName}.b2clogin.com/tfp/{tenantId}/";
        public static string ClientId
        {
            get
            {
                return clientId;
            }
        }
        public static string AuthoritySignin
        {
            get
            {
                return $"{authorityBase}{policySignin}";
            }
        }
        public static string AuthorityPasswordReset
        {
            get
            {
                return $"{authorityBase}{policyPassword}";
            }
        }
        public static string[] Scopes
        {
            get
            {
                return scopes;
            }
        }
        public static string IosKeychainSecurityGroups
        {
            get
            {
                return iosKeychainSecurityGroup;
            }
        }
    }
}
