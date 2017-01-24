using BootStrapTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace BootStrapTest.Helpers
{
	public static class RadioButtonHelpers
	{
		public static MvcHtmlString RadioButtonListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, Func<dynamic, HelperResult> label = null)
		{
			var name = ExpressionHelper.GetExpressionText(expression);

			var fullName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);

			var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

			var value = metadata.Model.ToString();

			var result = new StringBuilder();

			var selectList = (IEnumerable<SelectListItem>)htmlHelper.ViewData.Eval(name);

			foreach (var selectListItem in selectList)
			{
				var id = fullName + "-" + selectListItem.Value;

				var tagBuilder = new TagBuilder("input");

				tagBuilder.MergeAttribute("id", id);
				tagBuilder.MergeAttribute("type", "radio");
				tagBuilder.MergeAttribute("name", fullName, true);
				tagBuilder.MergeAttribute("value", selectListItem.Value);

				if (selectListItem.Value == value)
				{
					tagBuilder.MergeAttribute("checked", "checked");
				}

				result.Append(tagBuilder.ToString(TagRenderMode.SelfClosing));

				if (label != null)
				{
					//var helperResult = label(new RadioButtonLabelItem { Id = id, Name = selectListItem.Text });
					var helperResult = label(new SectionViewModel { Value = id, DisplayText = selectListItem.Text });

					result.Append(helperResult.ToHtmlString());
				}
			}

			return MvcHtmlString.Create(result.ToString());
		}

		//public class RadioButtonLabelItem
		//{
		//	public string Id { get; set; }

		//	public string Name { get; set; }
		//}
	}
}