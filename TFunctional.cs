using System.Collections.Generic;

namespace ConsoleApplication1
{
    interface TFunctional
    {
        void CreateBaseInfo();
        void Add<T>(T value, List<T> GenericList);
        void Delete<T>(List<T> GenericList);
        void ShowInfo<T>(List<T> GenericList);
        void Edit(object value);
        void ShowAllInfo<T>(List<T> GenericList);
    }
}
