using System;

namespace xf.exam.users.ViewModels
{
    public class GenericEventArgs<T> : EventArgs
    {
        public T Result { get; set; }
        public GenericEventArgs(T _result)
        {
            Result = _result;
        }
    }
}
