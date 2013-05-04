using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicGame
{
    /// <summary>
    /// The basic interface for a card.
    /// </summary>
    interface ICard
    {
        /// <summary>
        /// fetches the name of the card
        /// </summary>
        /// <returns> the name of the card </returns>
        public String getName();

        /// <summary>
        /// fetches the cost to play the card
        /// </summary>
        /// <returns> the cost of the card </returns>
        public ICost getCost();

        /// <summary>
        /// fetches the type of the card
        /// </summary>
        /// <returns>the type of the card </returns>
        public ICardType getType();

        /// <summary>
        /// fetches the list of actions the card has
        /// </summary>
        /// <returns>the list of actions for the card </returns>
        public List<IAction> getActions();

        /// <summary>
        /// fetches the toughness/damage of the card if it is a creature. If it is not, this will return an EmptyCreatureStats
        /// </summary>
        /// <returns>the toughness/damage of the card</returns>
        public ICreatureStats getCreatureStats();


    }
}
