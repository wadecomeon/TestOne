// 10/09/2009 Modified by Jimmy, use Smtp Send Email

/*
using System;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data.OleDb;
using System.Collections;
using System.Web.Mail;

namespace CIPACE.Components
{
	/// <summary>
	/// Summary description for Mail.
	/// </summary>
	public class Mail
	{
		protected string m_SmtpSender;
		protected string m_SmtpServer;
		protected string MailBody;
		protected string MailTo;
		protected string MailCC;
		protected string MailSubject;
		public MailMessage mail;

		private Thread thread;
		private bool sendSuccess;

		public Mail()
		{
			//
			// TODO: Add constructor logic here
			mail = new MailMessage();
			m_SmtpSender = System.Configuration.ConfigurationSettings.AppSettings["SmtpSender"];
			m_SmtpServer = System.Configuration.ConfigurationSettings.AppSettings["SmtpServer"];
			//
		}

		public bool sendEmail(string BodyContent,string MailSubject,string MailTo,string MailCC)
		{
			try
			{
				mail.To = MailTo.ToString();
				mail.Subject = MailSubject.ToString();
				mail.Body = BodyContent.ToString();
				mail.BodyFormat = MailFormat.Html;
				mail.From = m_SmtpSender.ToString();
				SmtpMail.SmtpServer= m_SmtpServer.ToString();
				SmtpMail.Send(mail);

				return true;
			}
			catch
			{
				return false;
			}			
		}



		
		//NewCIPACE: modified by Song Wenping on 02/06/2004
		public Mail(string BodyContent,string MailSubject,string MailTo,string MailCC)
		{
			//
			// TODO: Add constructor logic here
			mail = new MailMessage();
			m_SmtpSender = System.Configuration.ConfigurationSettings.AppSettings["SmtpSender"];
			m_SmtpServer = System.Configuration.ConfigurationSettings.AppSettings["SmtpServer"];
			//

			
			mail.To = MailTo;
			mail.Subject = MailSubject;
			mail.Body = BodyContent;
			mail.BodyFormat = MailFormat.Html;
			mail.From = m_SmtpSender;
		}

		public void SendMail()
		{
			sendSuccess=false;
			thread=new Thread(new ThreadStart(Send));
			thread.Start();
		}
		public bool SendSuccess
		{
			get
			{
				return sendSuccess;
			}
		}
		private void Send()
		{
			while(true)
			{
				try
				{
					SmtpMail.SmtpServer= m_SmtpServer;
					SmtpMail.Send(mail);
					thread.Abort();
					sendSuccess=true;
				}
				catch{}
			}
		}
	}
}
*/