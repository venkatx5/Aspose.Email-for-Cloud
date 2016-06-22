package com.aspose.email.model;

import java.util.*;
import com.aspose.email.model.Link;
import com.aspose.email.model.EmailDocument;
public class EmailDocumentResponse {
  private Link Link = null;
  private List<EmailProperty> Properties = new ArrayList<EmailProperty>();
  private EmailDocument Document = null;
  private String Code = null;
  private String Status = null;
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
	 * getProperties
	 * Gets List<EmailProperty>
	 * @return Properties
	 */
  public List<EmailProperty> getProperties() {
    return Properties;
  }

	/**
	 * setProperties
	 * Sets List<EmailProperty>
	 * @param Properties List<EmailProperty>
	 */
  public void setProperties(List<EmailProperty> Properties) {
    this.Properties = Properties;
  }

  /**
	 * getDocument
	 * Gets EmailDocument
	 * @return Document
	 */
  public EmailDocument getDocument() {
    return Document;
  }

	/**
	 * setDocument
	 * Sets EmailDocument
	 * @param Document EmailDocument
	 */
  public void setDocument(EmailDocument Document) {
    this.Document = Document;
  }

  /**
	 * getCode
	 * Gets String
	 * @return Code
	 */
  public String getCode() {
    return Code;
  }

	/**
	 * setCode
	 * Sets String
	 * @param Code String
	 */
  public void setCode(String Code) {
    this.Code = Code;
  }

  /**
	 * getStatus
	 * Gets String
	 * @return Status
	 */
  public String getStatus() {
    return Status;
  }

	/**
	 * setStatus
	 * Sets String
	 * @param Status String
	 */
  public void setStatus(String Status) {
    this.Status = Status;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailDocumentResponse {\n");
    sb.append("  Link: ").append(Link).append("\n");
    sb.append("  Properties: ").append(Properties).append("\n");
    sb.append("  Document: ").append(Document).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

