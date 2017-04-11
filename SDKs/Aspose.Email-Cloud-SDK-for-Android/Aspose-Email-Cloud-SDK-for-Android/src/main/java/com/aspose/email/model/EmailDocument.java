package com.aspose.email.model;

import java.util.*;
import java.io.InputStream;
import com.aspose.email.model.EmailProperties;
public class EmailDocument {
  private List<Link> Links = new ArrayList<Link>();
  private EmailProperties DocumentProperties = null;
  private InputStream Data = null;
  private String Format = null;
  /**
	 * getLinks
	 * Gets List<Link>
	 * @return Links
	 */
  public List<Link> getLinks() {
    return Links;
  }

	/**
	 * setLinks
	 * Sets List<Link>
	 * @param Links List<Link>
	 */
  public void setLinks(List<Link> Links) {
    this.Links = Links;
  }

  /**
	 * getDocumentProperties
	 * Gets EmailProperties
	 * @return DocumentProperties
	 */
  public EmailProperties getDocumentProperties() {
    return DocumentProperties;
  }

	/**
	 * setDocumentProperties
	 * Sets EmailProperties
	 * @param DocumentProperties EmailProperties
	 */
  public void setDocumentProperties(EmailProperties DocumentProperties) {
    this.DocumentProperties = DocumentProperties;
  }

  /**
	 * getData
	 * Gets System.IO.Stream
	 * @return Data
	 */
  public InputStream getData() {
    return Data;
  }

	/**
	 * setData
	 * Sets System.IO.Stream
	 * @param Data System.IO.Stream
	 */
  public void setData(InputStream Data) {
    this.Data = Data;
  }

  /**
	 * getFormat
	 * Gets String
	 * @return Format
	 */
  public String getFormat() {
    return Format;
  }

	/**
	 * setFormat
	 * Sets String
	 * @param Format String
	 */
  public void setFormat(String Format) {
    this.Format = Format;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailDocument {\n");
    sb.append("  Links: ").append(Links).append("\n");
    sb.append("  DocumentProperties: ").append(DocumentProperties).append("\n");
    sb.append("  Data: ").append(Data).append("\n");
    sb.append("  Format: ").append(Format).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

