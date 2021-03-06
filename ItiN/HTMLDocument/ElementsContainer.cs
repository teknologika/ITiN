#region WatiN Copyright (C) 2006-2007 Jeroen van Menen

//Copyright 2006-2007 Jeroen van Menen
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

#endregion Copyright

using System.Collections;
using System.Text.RegularExpressions;
using mshtml;

using ItiN.Interfaces;

namespace ItiN
{
    /// <summary>
    /// Summary description for ElementsContainer.
    /// </summary>
    public class ElementsContainer : Element, IElementsContainer, IElementCollection
    {
        public ElementsContainer(DomContainer ie, object element)
            : base(ie, element)
        { }

        public ElementsContainer(DomContainer ie, ElementFinder finder)
            : base(ie, finder)
        { }

        public ElementsContainer(Element element, ArrayList elementTags)
            : base(element, elementTags)
        { }

        #region IElementsContainer

        public Button Button(string elementClassName)
        {
            return Button(Find.ByCustom("ClassName", elementClassName));
        }

        public Button Button(Regex elementClassName)
        {
            return Button(Find.ByCustom("ClassName", elementClassName));
        }

        public Button Button(Attribute findBy)
        {
            return new Button(DomContainer, ElementFinder.ButtonFinder(findBy, this));
        }

        public ButtonCollection Buttons
        {
            get { return new ButtonCollection(DomContainer, ElementFinder.ButtonFinder(null, this)); }
        }

        public Element Element(string elementClassName)
        {
            return Element(Find.ByCustom("ClassName", elementClassName));
        }

        public Element Element(Regex elementClassName)
        {
            return Element(Find.ByCustom("ClassName", elementClassName));
        }

        public Element Element(Attribute findBy)
        {
            return ElementsSupport.Element(DomContainer, findBy, this);
        }

        public ElementCollection Elements
        {
            get { return ElementsSupport.Elements(DomContainer, this); }
        }

        public CheckBox CheckBox(string elementClassName)
        {
            return CheckBox(Find.ByCustom("ClassName", elementClassName));
        }

        public CheckBox CheckBox(Regex elementClassName)
        {
            return CheckBox(Find.ByCustom("ClassName", elementClassName));
        }

        public CheckBox CheckBox(Attribute findBy)
        {
            return ElementsSupport.CheckBox(DomContainer, findBy, this);
        }

        public CheckBoxCollection CheckBoxes
        {
            get { return ElementsSupport.CheckBoxes(DomContainer, this); }
        }

        public SelectList SelectList(string elementClassName)
        {
            return SelectList(Find.ByCustom("ClassName", elementClassName));
        }

        public SelectList SelectList(Regex elementClassName)
        {
            return SelectList(Find.ByCustom("ClassName", elementClassName));
        }

        public SelectList SelectList(Attribute findBy)
        {
            return ElementsSupport.SelectList(DomContainer, findBy, this);
        }

        public SelectListCollection SelectLists
        {
            get { return ElementsSupport.SelectLists(DomContainer, this); }
        }

        public RadioButton RadioButton(string elementClassName)
        {
            return RadioButton(Find.ByCustom("ClassName", elementClassName));
        }

        public RadioButton RadioButton(Regex elementClassName)
        {
            return RadioButton(Find.ByCustom("ClassName", elementClassName));
        }

        public RadioButton RadioButton(Attribute findBy)
        {
            return ElementsSupport.RadioButton(DomContainer, findBy, this);
        }

        public RadioButtonCollection RadioButtons
        {
            get { return ElementsSupport.RadioButtons(DomContainer, this); }
        }

        public TextField TextField(string elementClassName)
        {
            return TextField(Find.ByCustom("ClassName", elementClassName));
        }

        public TextField TextField(Regex elementClassName)
        {
            return TextField(Find.ByCustom("ClassName", elementClassName));
        }

        public TextField TextField(Attribute findBy)
        {
            return ElementsSupport.TextField(DomContainer, findBy, this);
        }

        public TextFieldCollection TextFields
        {
            get { return ElementsSupport.TextFields(DomContainer, this); }
        }

        public Span Span(string elementId)
        {
            return Span(Find.ById(elementId));
        }

        public Span Span(Regex elementId)
        {
            return Span(Find.ById(elementId));
        }

        public Span Span(Attribute findBy)
        {
            return ElementsSupport.Span(DomContainer, findBy, this);
        }

        public SpanCollection Spans
        {
            get { return ElementsSupport.Spans(DomContainer, this); }
        }

        public Div Div(string elementId)
        {
            return Div(Find.ById(elementId));
        }

        public Div Div(Regex elementId)
        {
            return Div(Find.ById(elementId));
        }

        public Div Div(Attribute findBy)
        {
            return ElementsSupport.Div(DomContainer, findBy, this);
        }

        public DivCollection Divs
        {
            get { return ElementsSupport.Divs(DomContainer, this); }
        }


        #region The following WatiN elements are not supported in ItiN


        //public FileUpload FileUpload(string elementId)
        //{
        //    return FileUpload(Find.ById(elementId));
        //}

        //public FileUpload FileUpload(Regex elementId)
        //{
        //    return FileUpload(Find.ById(elementId));
        //}

        //public FileUpload FileUpload(Attribute findBy)
        //{
        //    return ElementsSupport.FileUpload(DomContainer, findBy, this);
        //}

        //public FileUploadCollection FileUploads
        //{
        //    get { return ElementsSupport.FileUploads(DomContainer, this); }
        //}

        //public Form Form(string elementId)
        //{
        //    return Form(Find.ById(elementId));
        //}

        //public Form Form(Regex elementId)
        //{
        //    return Form(Find.ById(elementId));
        //}

        //public Form Form(Attribute findBy)
        //{
        //    return ElementsSupport.Form(DomContainer, findBy, this);
        //}

        //public FormCollection Forms
        //{
        //    get { return ElementsSupport.Forms(DomContainer, this); }
        //}

        //public Label Label(string elementId)
        //{
        //    return Label(Find.ById(elementId));
        //}

        //public Label Label(Regex elementId)
        //{
        //    return Label(Find.ById(elementId));
        //}

        //public Label Label(Attribute findBy)
        //{
        //    return ElementsSupport.Label(DomContainer, findBy, this);
        //}

        //public LabelCollection Labels
        //{
        //    get { return ElementsSupport.Labels(DomContainer, this); }
        //}

        //public Link Link(string elementId)
        //{
        //    return Link(Find.ById(elementId));
        //}

        //public Link Link(Regex elementId)
        //{
        //    return Link(Find.ById(elementId));
        //}

        //public Link Link(Attribute findBy)
        //{
        //    return ElementsSupport.Link(DomContainer, findBy, this);
        //}

        //public LinkCollection Links
        //{
        //    get { return ElementsSupport.Links(DomContainer, this); }
        //}

        //public Para Para(string elementId)
        //{
        //    return Para(Find.ById(elementId));
        //}

        //public Para Para(Regex elementId)
        //{
        //    return Para(Find.ById(elementId));
        //}

        //public Para Para(Attribute findBy)
        //{
        //    return ElementsSupport.Para(DomContainer, findBy, this);
        //}

        //public ParaCollection Paras
        //{
        //    get { return ElementsSupport.Paras(DomContainer, this); }
        //}

        //public Table Table(string elementId)
        //{
        //    return Table(Find.ById(elementId));
        //}

        //public Table Table(Regex elementId)
        //{
        //    return Table(Find.ById(elementId));
        //}

        //public Table Table(Attribute findBy)
        //{
        //    return ElementsSupport.Table(DomContainer, findBy, this);
        //}

        //public TableCollection Tables
        //{
        //    get { return ElementsSupport.Tables(DomContainer, this); }
        //}

        ////    public TableSectionCollection TableSections
        ////    {
        ////      get { return SubElementsSupport.TableSections(Ie, this); }
        ////    }

        //public TableCell TableCell(string elementId)
        //{
        //    return TableCell(Find.ById(elementId));
        //}

        //public TableCell TableCell(Regex elementId)
        //{
        //    return TableCell(Find.ById(elementId));
        //}

        //public TableCell TableCell(Attribute findBy)
        //{
        //    return ElementsSupport.TableCell(DomContainer, findBy, this);
        //}

        ///// <summary>
        ///// Finds a TableCell by the n-th index of an id. 
        ///// index counting is zero based.
        ///// </summary>  
        ///// <example>
        ///// This example will get the Text of the third(!) tablecell 
        ///// with "tablecellid" as it's id value. 
        ///// <code>ie.TableCell("tablecellid", 2).Text</code>
        ///// </example>
        //public TableCell TableCell(string elementId, int index)
        //{
        //    return ElementsSupport.TableCell(DomContainer, elementId, index, this);
        //}

        //public TableCell TableCell(Regex elementId, int index)
        //{
        //    return ElementsSupport.TableCell(DomContainer, elementId, index, this);
        //}

        //public TableCellCollection TableCells
        //{
        //    get { return ElementsSupport.TableCells(DomContainer, this); }
        //}

        //public TableRow TableRow(string elementId)
        //{
        //    return TableRow(Find.ById(elementId));
        //}

        //public TableRow TableRow(Regex elementId)
        //{
        //    return TableRow(Find.ById(elementId));
        //}

        //public virtual TableRow TableRow(Attribute findBy)
        //{
        //    return ElementsSupport.TableRow(DomContainer, findBy, this);
        //}

        //public virtual TableRowCollection TableRows
        //{
        //    get { return ElementsSupport.TableRows(DomContainer, this); }
        //}

        //public TableBody TableBody(string elementId)
        //{
        //    return TableBody(Find.ById(elementId));
        //}

        //public TableBody TableBody(Regex elementId)
        //{
        //    return TableBody(Find.ById(elementId));
        //}

        //public virtual TableBody TableBody(Attribute findBy)
        //{
        //    return ElementsSupport.TableBody(DomContainer, findBy, this);
        //}

        //public virtual TableBodyCollection TableBodies
        //{
        //    get { return ElementsSupport.TableBodies(DomContainer, this); }
        //}

      

       
        //public Image Image(string elementId)
        //{
        //    return Image(Find.ById(elementId));
        //}

        //public Image Image(Regex elementId)
        //{
        //    return Image(Find.ById(elementId));
        //}

        //public Image Image(Attribute findBy)
        //{
        //    return ElementsSupport.Image(DomContainer, findBy, this);
        //}

        //public ImageCollection Images
        //{
        //    get { return ElementsSupport.Images(DomContainer, this); }
        //}
        #endregion
        #endregion

        IHTMLElementCollection IElementCollection.Elements
        {
            get
            {
                try
                {
                    if (Exists)
                    {
                        return (IHTMLElementCollection)htmlElement.all;
                    }

                    return null;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
