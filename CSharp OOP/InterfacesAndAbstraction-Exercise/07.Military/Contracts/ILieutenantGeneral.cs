using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivates(IPrivate @private);
    }
}
