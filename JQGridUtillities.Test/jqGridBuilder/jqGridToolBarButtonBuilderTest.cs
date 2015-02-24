using JQGridUtilities.JQGridBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trirand.Web.Mvc;

namespace JQGridUtilities.Test.jqGridBuilder
{
	[TestClass]
	public class jqGridToolBarButtonBuilderTest
	{
		[TestInitialize]
		public void Initialize()
		{
			JQGridToolBarButtonBuilder.Initialize();
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultEdit();

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInSpanish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultEdit();

			Assert.AreEqual("Editar la fila seleccionada", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd();

			Assert.AreEqual("New row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInSpanish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd();

			Assert.AreEqual("Nueva fila", button.ToolTip);
		}

		//NonDefaultViewRow
		[TestMethod]
		public void NonDefaultViewRow_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultViewRow();

			Assert.AreEqual("View selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultViewRow_TooltipInSpanish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultViewRow();

			Assert.AreEqual("Ver la fila seleccionada", button.ToolTip);
		}

		//ColumnChooser
		[TestMethod]
		public void ColumnChooser_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.ColumnChooser();

			Assert.AreEqual("Show/hide columns", button.ToolTip);
		}

		[TestMethod]
		public void ColumnChooser_TooltipInSpanish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.ColumnChooser();

			Assert.AreEqual("Mostrar/ocultar columnas", button.ToolTip);
		}

		//Comments
		[TestMethod]
		public void Comments_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Comments();

			Assert.AreEqual("Comments", button.ToolTip);
		}

		[TestMethod]
		public void Comments_TooltipInSpanish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Comments();

			Assert.AreEqual("Conversación", button.ToolTip);
		}

		[TestMethod]
		public void Comments_DefaultButtonIcon()
		{
			Assert.AreEqual("ui-icon-comment", JQGridToolBarButtonBuilder.Comments().ButtonIcon);
		}

		[TestMethod]
		public void Comments_DefaultText()
		{
			Assert.AreEqual(" ", JQGridToolBarButtonBuilder.Comments().Text);
		}

		[TestMethod]
		public void Comments_DefaultPosition()
		{
			Assert.AreEqual(ToolBarButtonPosition.Last, JQGridToolBarButtonBuilder.Comments().Position);
		}

		[TestMethod]
		public void Comments_DefaultOnClickFunction()
		{
			Assert.AreEqual("comments", JQGridToolBarButtonBuilder.Comments().OnClick);
		}

		//Print
		[TestMethod]
		public void Print_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Print();

			Assert.AreEqual("Print selected row", button.ToolTip);
		}

		[TestMethod]
		public void Print_TooltipInSpanish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Print();

			Assert.AreEqual("Imprimir la fila seleccionada", button.ToolTip);
		}

		[TestMethod]
		public void Print_DefaultButtonIcon()
		{
			Assert.AreEqual("ui-icon-print", JQGridToolBarButtonBuilder.Print().ButtonIcon);
		}

		[TestMethod]
		public void Print_DefaultText()
		{
			Assert.AreEqual(" ", JQGridToolBarButtonBuilder.Print().Text);
		}

		[TestMethod]
		public void Print_DefaultPosition()
		{
			Assert.AreEqual(ToolBarButtonPosition.Last, JQGridToolBarButtonBuilder.Print().Position);
		}

		[TestMethod]
		public void Print_DefaultOnClickFunction()
		{
			Assert.AreEqual("print", JQGridToolBarButtonBuilder.Print().OnClick);
		}

		[TestMethod]
		public void OnStartDefaultLanguage_ReturnEnglish()
		{
			Assert.AreEqual(jqGridBuildersLanguages.English, JQGridToolBarButtonBuilder.DefaultLanguage);
		}

		[TestMethod]
		public void SetDefaultLanguage_ChangeToSpanish()
		{
			Assert.AreEqual(jqGridBuildersLanguages.English, JQGridToolBarButtonBuilder.DefaultLanguage);

			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);

			Assert.AreEqual(jqGridBuildersLanguages.Spanish, JQGridToolBarButtonBuilder.DefaultLanguage);
		}

		[TestMethod]
		public void Initialize_SetDefaultLanguageToEnglish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.Spanish);

			JQGridToolBarButtonBuilder.Initialize();

			Assert.AreEqual(jqGridBuildersLanguages.English, JQGridToolBarButtonBuilder.DefaultLanguage);
		}

		[TestMethod]
		public void SetDefaultLanguage_ChangeToEnglish()
		{
			JQGridToolBarButtonBuilder.SetDefaultLanguage(jqGridBuildersLanguages.English);

			Assert.AreEqual(jqGridBuildersLanguages.English, JQGridToolBarButtonBuilder.DefaultLanguage);
		}
	}
}