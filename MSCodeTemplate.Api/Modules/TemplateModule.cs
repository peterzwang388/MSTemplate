
using MSCodeTemplate.Api.BusinessModels.Request;
using MSCodeTemplate.Api.Services.Interfaces;
using Nancy;
using Nancy.ModelBinding;

namespace MSCodeTemplate.Api.Modules
{
    public class TemplateModule : NancyModule
    {
        public TemplateModule(ITemplateService templateService)
            : base("api/")
        {
            Get["/test",true] = async (_, ct) => await templateService.GetTest("");

            Get["/members/{ReferenceNumber}", true] = async (_, ct) =>
            {
                MemberNameRequest idx = this.Bind<MemberNameRequest>();
              return   await templateService.GetMemberName(idx.ReferenceNumber);
            };
        }
    }
}