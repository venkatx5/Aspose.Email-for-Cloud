using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Email.Model {
  public class MailServerFolder {
    public string Name { get; set; }

    public string Id { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MailServerFolder {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
