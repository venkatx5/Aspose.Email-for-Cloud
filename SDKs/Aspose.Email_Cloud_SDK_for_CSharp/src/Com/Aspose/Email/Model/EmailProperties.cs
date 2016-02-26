using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Email.Model {
  public class EmailProperties {
    public Link Link { get; set; }

    public List<EmailProperty> List { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailProperties {\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  List: ").Append(List).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
