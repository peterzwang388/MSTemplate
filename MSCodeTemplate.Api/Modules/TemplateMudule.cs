
using MSCodeTemplate.Api.Services.Interfaces;
using Nancy;
using Nancy.ModelBinding;

namespace MSCodeTemplate.Api.Modules
{
    public class TemplateMudule : NancyModule
    {
        public TemplateMudule(ITemplateService templateService)
            : base("api/")
        {
            Get["/test",true] = async (_, ct) => await templateService.GetTest("");
        }
    }
}