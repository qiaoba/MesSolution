using Core.Service;
using System;
using System.ComponentModel.Composition;

namespace Frm.Service
{

	[Export(typeof(ITsErrorCodeFormService))]
	public class TsErrorCodeFormService : TsErrorCodeService ,ITsErrorCodeFormService
	{

	}
}
