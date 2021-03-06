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
using mshtml;

namespace ItiN
{
  /// <summary>
  /// This class provides specialized functionality for a HTML span element.
  /// </summary>
  public class Span : ElementsContainer
  {
    private static ArrayList elementTags;

    public static ArrayList ElementTags
    {
      get
      {
        if (elementTags == null)
        {
          elementTags = new ArrayList();
          elementTags.Add(new ElementTag("span"));
        }

        return elementTags;
      }
    }

    public Span(DomContainer ie, IHTMLSpanElement htmlSpanElement) : base(ie, (IHTMLElement) htmlSpanElement)
    {}
    
    public Span(DomContainer ie, ElementFinder finder) : base(ie, finder)
    {}
    
    /// <summary>
    /// Initialises a new instance of the <see cref="Span"/> class based on <paramref name="element"/>.
    /// </summary>
    /// <param name="element">The element.</param>
    public Span(Element element) : base(element, ElementTags)
    {}

  }
}