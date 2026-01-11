namespace CreationalDesignPatterns.Interfaces;
internal interface IMyCloneable<T>
{
    T DeepClone();
}
