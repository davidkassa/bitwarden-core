﻿namespace Bit.Core
{
    public class GlobalSettings
    {
        public bool SelfHosted { get; set; }
        public virtual string SiteName { get; set; }
        public virtual string BaseVaultUri { get; set; }
        public virtual string BaseApiUri { get; set; }
        public virtual string BaseIdentityUri { get; set; }
        public virtual string StripeApiKey { get; set; }
        public virtual SqlServerSettings SqlServer { get; set; } = new SqlServerSettings();
        public virtual MailSettings Mail { get; set; } = new MailSettings();
        public virtual StorageSettings Storage { get; set; } = new StorageSettings();
        public virtual AttachmentSettings Attachment { get; set; } = new AttachmentSettings();
        public virtual IdentityServerSettings IdentityServer { get; set; } = new IdentityServerSettings();
        public virtual DataProtectionSettings DataProtection { get; set; } = new DataProtectionSettings();
        public virtual DocumentDbSettings DocumentDb { get; set; } = new DocumentDbSettings();
        public virtual NotificationHubSettings NotificationHub { get; set; } = new NotificationHubSettings();
        public virtual YubicoSettings Yubico { get; set; } = new YubicoSettings();
        public virtual DuoSettings Duo { get; set; } = new DuoSettings();
        public virtual U2fSettings U2f { get; set; } = new U2fSettings();
        public virtual BraintreeSettings Braintree { get; set; } = new BraintreeSettings();

        public class SqlServerSettings
        {
            public string ConnectionString { get; set; }
        }

        public class StorageSettings
        {
            public string ConnectionString { get; set; }
        }

        public class AttachmentSettings
        {
            public string ConnectionString { get; set; }
            public string BaseUrl { get; set; }
        }

        public class MailSettings
        {
            public string ReplyToEmail { get; set; }
            public string SendGridApiKey { get; set; }
            public SmtpSettings Smtp { get; set; } = new SmtpSettings();

            public class SmtpSettings
            {
                public string Host { get; set; }
                public int Port { get; set; }
                public bool Ssl { get; set; }
                public string Username { get; set; }
                public string Password { get; set; }
            }
        }

        public class IdentityServerSettings
        {
            public string CertificateThumbprint { get; set; }
        }

        public class DataProtectionSettings
        {
            public string CertificateThumbprint { get; set; }
        }

        public class DocumentDbSettings
        {
            public string Uri { get; set; }
            public string Key { get; set; }
        }

        public class NotificationHubSettings
        {
            public string ConnectionString { get; set; }
            public string HubName { get; set; }
        }

        public class YubicoSettings
        {
            public string ClientId { get; set; }
            public string Key { get; set; }
        }

        public class DuoSettings
        {
            public string AKey { get; set; }
        }

        public class U2fSettings
        {
            public string AppId { get; set; }
        }

        public class BraintreeSettings
        {
            public bool Production { get; set; }
            public string MerchantId { get; set; }
            public string PublicKey { get; set; }
            public string PrivateKey { get; set; }
        }
    }
}
