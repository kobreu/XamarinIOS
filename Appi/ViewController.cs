using System;
using UIKit;
using Payworks;

namespace Appi
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			//Console.WriteLine(MPProviderMode.Test);

			//var i = new Foundation.NSNumber(2);

			var transactionProvider = MPMpos.TransactionProviderForMode(MPProviderMode.Test, "identifier", "secret");

			var factory = MPMpos.ProviderOptionsFactory();

			var version = MPMpos.Version();

			Console.WriteLine(version);
			Console.WriteLine(MPMpos.Build());

				//Console.WriteLine("llalala");
			var amount = new Foundation.NSDecimalNumber("10.2");

			MPTransactionParameters transactionParameters = MPTransactionParameters.ChargeWithAmount(amount, MPCurrency.EUR, null);

			MPTransactionParameters transactionParameters2 = MPTransactionParameters.RefundForCustomIdentifier("alkjaljks", null);

			MPAccessoryParameters accessoryParameters = MPAccessoryParameters.MockAccessoryParameters();



			//MPAccessoryParameters accessoryParamters2 = MPAccessoryParameters.ExternalAccessoryParametersWithFamily(MPAccessoryFamily.MiuraMPI, "com.miura.shuttle", null);

			MPTransactionProcess process = transactionProvider.StartTransactionWithParameters(transactionParameters, accessoryParameters, Registered, StatusChanged, ActionRequired, Completed);
		}

		public static void Registered(MPTransactionProcess p, MPTransaction t)
		{
		}

		public static void StatusChanged(MPTransactionProcess p, MPTransaction t, MPTransactionProcessDetails pd)
		{
		}

		public static void ActionRequired(MPTransactionProcess p, MPTransaction t, int i, MPTransactionActionSupport tas)
		{
		}

		public static void Completed(MPTransactionProcess p, MPTransaction t, MPTransactionProcessDetails tpd)
		{
		}






		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
