using Trirand.Web.Mvc;

namespace JQGridUtilities.JQGridBuilders
{
	public class JQGridEditFieldAttributeBuilder
	{
		private string _styleName = "style";
		private string _styleValue = "";

		public JQGridEditFieldAttributeBuilder StyleTextUpperCase()
		{
			_styleValue += "text-transform: uppercase;";
			return this;
		}

		public JQGridEditFieldAttributeBuilder StyleWidth(int value)
		{
			_styleValue += string.Format("width: {0}px;", value);
			return this;
		}

		public JQGridEditFieldAttributeBuilder StyleHeight(int value)
		{
			_styleValue += string.Format("height: {0}px;", value);
			return this;
		}

		public JQGridEditFieldAttribute BuildStyle()
		{
			if (string.IsNullOrEmpty(_styleValue))
				return null;

			var styleName = _styleName;
			var styleValue = _styleValue;
			
			ResetEnvironment();
			
			return new JQGridEditFieldAttribute() { Name = styleName, Value = styleValue };
		}

		public JQGridEditFieldAttribute BuildMaxLength(int value)
		{
			return new JQGridEditFieldAttribute() { Name = "maxlength", Value = string.Format("{0};", value) };
		}

		public JQGridEditFieldAttribute BuildNumbersOnly()
		{
			return new JQGridEditFieldAttribute() { Name = "onkeypress", Value = "return numbersOnly(event);" };
		}

		private void ResetEnvironment()
		{
			_styleName = "style";
			_styleValue = "";
		}
	}
}