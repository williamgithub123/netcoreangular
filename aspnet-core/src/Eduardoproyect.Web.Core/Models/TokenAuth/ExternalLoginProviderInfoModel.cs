using Abp.AutoMapper;
using Eduardoproyect.Authentication.External;

namespace Eduardoproyect.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
