package com.aspose.email.model;

import com.aspose.email.model.Link;
public class EmailProperty {
  private Link Link = null;
  private String Name = null;
  private Object Value = null;
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
	 * getName
	 * Gets String
	 * @return Name
	 */
  public String getName() {
    return Name;
  }

	/**
	 * setName
	 * Sets String
	 * @param Name String
	 */
  public void setName(String Name) {
    this.Name = Name;
  }

  /**
	 * getValue
	 * Gets Object
	 * @return Value
	 */
  public Object getValue() {
    return Value;
  }

	/**
	 * setValue
	 * Sets Object
	 * @param Value Object
	 */
  public void setValue(Object Value) {
    this.Value = Value;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailProperty {\n");
    sb.append("  Link: ").append(Link).append("\n");
    sb.append("  Name: ").append(Name).append("\n");
    sb.append("  Value: ").append(Value).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

