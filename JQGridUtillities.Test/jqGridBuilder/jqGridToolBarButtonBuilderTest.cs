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
		public void NonDefaultEdit_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultEdit(jqGridBuildersLanguages.English);

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultEdit(jqGridBuildersLanguages.Spanish);

			Assert.AreEqual("Editar la fila seleccionada", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd();

			Assert.AreEqual("New row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd(jqGridBuildersLanguages.English);

			Assert.AreEqual("New row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd(jqGridBuildersLanguages.Spanish);

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
		public void NonDefaultViewRow_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultViewRow(jqGridBuildersLanguages.English);

			Assert.AreEqual("View selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultViewRow_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultViewRow(jqGridBuildersLanguages.Spanish);

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
		public void ColumnChooser_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.ColumnChooser(jqGridBuildersLanguages.English);

			Assert.AreEqual("Show/hide columns", button.ToolTip);
		}

		[TestMethod]
		public void ColumnChooser_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.ColumnChooser(jqGridBuildersLanguages.Spanish);

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
		public void Comments_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Comments(jqGridBuildersLanguages.English);

			Assert.AreEqual("Comments", button.ToolTip);
		}

		[TestMethod]
		public void Comments_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Comments(jqGridBuildersLanguages.Spanish);

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
		public void Print_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Print(jqGridBuildersLanguages.English);

			Assert.AreEqual("Print selected row", button.ToolTip);
		}

		[TestMethod]
		public void Print_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.Print(jqGridBuildersLanguages.Spanish);

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