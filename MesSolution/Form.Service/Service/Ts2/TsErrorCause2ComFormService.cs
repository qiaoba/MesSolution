using Core.Service;
using System;
using System.ComponentModel.Composition;

namespace FormApplication.Service
{

	[Export(typeof(IErrorComFormService))]
	public class TsErrorCause2ComFormService : TsErrorCause2ComService ,IErrorComFormService
	{

	}
}
