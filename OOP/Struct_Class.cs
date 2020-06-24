/*
 * Ref: https://www.youtube.com/watch?v=4eDFpuDGosA&list=PLNLbdN-_vroNA4eWzJanw9ynCsAYY9KHp
 * 
 * Struct:
 *  1. Value type, data is stored in Stack
 *  2. When using as a param
 *      A new copy of struct is used
 *      Do not effect the original struct
 *  3. Big struct may effect performance since Stack memory is smaller than heap
 * 
 * Class:
 *  1. Ref type, data is store in Heap
 *  2. When usign as a param
 *      The obj address is passing => The original obj will be change
 */


namespace LeetCode.OOP
{
    public class Struct_Class
    {
        public void Test()
        {
            var structObj = new StructCoordinate(0, 0);
            var classObj = new ClassCoordinate(0, 0);

            ModifyStruct(structObj);
            ModifyClass(classObj);
            
        }
        public static void ModifyStruct(StructCoordinate c)
        {
            c.x += 1;
            c.y += 1;
        }

        public static void ModifyClass(ClassCoordinate c)
        {
            c.x += 1;
            c.y += 1;
        }
    }

    public struct StructCoordinate
    {
        public int x;
        public int y;

        public StructCoordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

    public class ClassCoordinate
    {
        public int x { get; set; }
        public int y { get; set; }

        public ClassCoordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
