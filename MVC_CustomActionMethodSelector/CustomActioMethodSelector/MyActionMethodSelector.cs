using System.Reflection;
using System.Web.Mvc;

namespace MVC_CustomActionMethodSelector.CustomActioMethodSelector
{
    public class ElectronicsActionMethodSelectorAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.Headers["P-Electronics"] != null;
        }
    }

    public class MechanicalActionMethodSelectorAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.Headers["P-Mechanical"] != null;
        }
    }
}