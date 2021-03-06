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
  /// Base class for <see cref="CheckBox"/> and <see cref="RadioButton"/> provides
  /// support for common functionality.
  /// </summary>
  public class RadioCheck : Element
  {
    public RadioCheck(DomContainer ie, IHTMLInputElement inputElement) : base(ie, (IHTMLElement) inputElement)
    {}
    
    public RadioCheck(DomContainer ie, ElementFinder finder) : base(ie, finder)
    {}

    /// <summary>
    /// Initialises a new instance of the <see cref="RadioCheck"/> class based on <paramref name="element"/>.
    /// </summary>
    /// <param name="element">The element.</param>
    /// <param name="elementTags">The element tags the element should match with.</param>
    public RadioCheck(Element element, ArrayList elementTags) : base(element, elementTags)
    {}

    public bool Checked
    {
      get { return inputElement.@checked; }
      set
      {
        Logger.LogAction("Selecting " + GetType().Name + " '" + ToString() + "'");
        
        Highlight(true);
        inputElement.@checked = value;
        FireEvent("onClick");
        Highlight(false);
      }
    }

    public override string ToString()
    {
      return Id;
    }

    private IHTMLInputElement inputElement
    {
      get { return ((IHTMLInputElement) HTMLElement); }
    }
  }
}
