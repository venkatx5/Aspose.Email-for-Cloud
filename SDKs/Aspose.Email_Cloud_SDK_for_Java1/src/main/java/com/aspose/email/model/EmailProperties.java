package com.aspose.email.model;

import java.util.*;
import com.aspose.email.model.Link;
public class EmailProperties {
  private Link Link = null;
  private List<EmailProperty> List = new ArrayList<EmailProperty>();
  /**
	 * getLink
	 * Gets Link
	 * @return Link
	 */
  public Link getLink() {
    return Link;
  }

	/**
	 * setLink
	 * Sets Link
	 * @param Link Link
	 */
  public void setLink(Link Link) {
    this.Link = Link;
  }

  /**
	 * getList
	 * Gets List<EmailProperty>
	 * @return List
	 */
  public List<EmailProperty> getList() {
    return List;
  }

	/**
	 * setList
	 * Sets List<EmailProperty>
	 * @param List List<EmailProperty>
	 */
  public void setList(List<EmailProperty> List) {
    this.List = List;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailProperties {\n");
    sb.append("  Link: ").append(Link).append("\n");
    sb.append("  List: ").append(List).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

