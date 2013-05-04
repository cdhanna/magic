using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicGame
{
    interface IAction
    {
        /// <summary>
        /// fetches the cost of this action
        /// </summary>
        /// <returns>the cost of the action</returns>
        public ICost getCost();

        /// <summary>
        /// fetches the type of this action
        /// </summary>
        /// <returns>the type of the action</returns>
        public IActionType getType();

        /// <summary>
        /// run the action
        /// </summary>
        public void runEffects();

    }
}
