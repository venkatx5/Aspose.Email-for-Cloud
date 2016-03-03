using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Email.Model {
  public class EmailProperty {
    public Link Link { get; set; }

    public string Name { get; set; }

    public object Value { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailProperty {\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
