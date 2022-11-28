using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbsimulation
{
    public class tb
    {

		public float VCC, VBB, VCE, VCB, VBE;
		public float IC, IB, IE;
		public float hFE, betaDC, alfaDC;
		public float RB, RC, RE;
		public float VRB, VRC, VRE;



		public float fIE(float pIC, float pIB)
		{
			return pIC + pIB;
		}

		public float fbetaDC(float pIC, float pIB)
		{
			return pIC / pIB;
		}

		public float fhFE(float pbetaDC)
		{
			return pbetaDC;
		}

		public float falfaDC(float pIC, float pIE)
		{
			return pIC / pIE;
		}

		public float fVBE() { return 0.7f; }

		public float fVRB(float pVBB, float pVBE)
		{
			return pVBB - pVBE;
		}

		public float fVRB2(float pIB, float pRB)
		{
			return pIB * pRB;
		}

		public float fIB(float pVBB, float pVBE, float pRB)
		{
			return (pVBB - pVBE) / pRB;
		}

		public float fVCE(float pVCC, float pVRC)
		{
			return pVCC - pVRC;
		}

		public float fVRC(float pIC, float pRC)
		{
			return pIC * pRC;
		}

		public float fVRE(float pIE, float pRE)
		{
			return pIE * pRE;
		}



		public float fVCE(float pVCC, float pIC, float pRC)
		{
			return pVCC - (pIC * pRC);
		}

		public float fIC(float pbetaDC, float pIB)
		{
			return pbetaDC * pIB;
		}

		public float fVCB(float pVCE, float pVBE)
		{
			return pVCE - pVBE;
		}


		











	}
}
