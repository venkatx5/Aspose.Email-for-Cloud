package com.aspose.email.model;

import com.aspose.email.model.EmailProperty;
public class EmailPropertyResponse {
  private EmailProperty EmailProperty = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getEmailProperty
	 * Gets EmailProperty
	 * @return EmailProperty
	 */
  public EmailProperty getEmailProperty() {
    return EmailProperty;
  }

	/**
	 * setEmailProperty
	 * Sets EmailProperty
	 * @param EmailProperty EmailProperty
	 */
  public void setEmailProperty(EmailProperty EmailProperty) {
    this.EmailProperty = EmailProperty;
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
    sb.append("class EmailPropertyResponse {\n");
    sb.append("  EmailProperty: ").append(EmailProperty).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

