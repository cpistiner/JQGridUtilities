using JQGridUtilities.JQGridBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JQGridUtillities.Test.jqGridBuilder
{
	[TestClass]
	public class jqGridToolBarButtonBuilderTest
	{
		[TestMethod]
		public void NonDefaultEdit_SetTooltipByDefault()
		{
			var button = JQGridToolBarButtonBuilder.NonDefaultEdit();

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInEnglishByDefault()
		{
			var button = JQGridToolBarButtonBuilder.NonDefaultEdit();

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}
	}
}
