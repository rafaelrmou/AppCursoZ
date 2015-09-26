using System;
using Android.Speech.Tts;
using System.Collections.Generic;

[assembly : Xamarin.Forms.Dependency (typeof(RenderersEServices.Droid.Falar))]

namespace RenderersEServices.Droid
{
	public class Falar : Java.Lang.Object, RenderersEServices.IFalar, TextToSpeech.IOnInitListener
	{

		TextToSpeech speaker;

		string textAFalar;

		#region IFalar implementation

		public void Conversar (string texto)
		{
			var ctx = Xamarin.Forms.Forms.Context;

			textAFalar = texto;

			if (speaker == null) {
				speaker = new TextToSpeech (ctx, this);
			} else {
				var p = new Dictionary<string,string> ();

				speaker.Speak (textAFalar, QueueMode.Flush, p);
			}
		}

		public void OnInit (OperationResult status)
		{
			if (status.Equals (OperationResult.Success)) {
				var p = new Dictionary<string,string> ();
				speaker.Speak (textAFalar, QueueMode.Flush, p);
			}
		
		}

		#endregion

		public Falar ()
		{
		}
	}
}

