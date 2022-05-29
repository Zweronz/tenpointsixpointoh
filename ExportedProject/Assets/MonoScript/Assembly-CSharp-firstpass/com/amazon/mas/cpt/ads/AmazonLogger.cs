using System;

namespace com.amazon.mas.cpt.ads
{
	public class AmazonLogger
	{
		private readonly string tag;

		public AmazonLogger(string tag)
		{
			this.tag = tag;
		}

		public void Debug(string msg)
		{
			AmazonLogging.Log(AmazonLogging.AmazonLoggingLevel.Verbose, this.tag, msg);
		}

		public string getTag()
		{
			return this.tag;
		}
	}
}