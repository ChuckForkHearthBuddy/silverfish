using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_132_WARRIOR : SimTemplate //armorup
	{

        //    heldenfähigkeit Gain 4 Armor.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
		    p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 4);
		}
	}
}