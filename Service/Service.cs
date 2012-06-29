﻿using System.ServiceProcess;

namespace Service
{
	public partial class Service : ServiceBase
	{
		public Service()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
		}

		protected override void OnStop()
		{
		}

		public void InteractiveStart()
		{
			OnStart(null);
		}

		public void InteractiveStop()
		{
			OnStop();
		}
	}
}
