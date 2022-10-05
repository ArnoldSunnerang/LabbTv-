using Labb2_Class_Library;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



Shape[] randomShapes = new Shape[20];

int[] shapeCounter = new int[7];

float sumArea = 0;
float sumTrianglePerimeters = 0;

Vector3 zeroVector3 = new Vector3(0, 0, 0);
Shape3D largest3DShape = new Sphere(zeroVector3, 0);


SpawnShapes();
SeeShapes(randomShapes);
ShowShapes();






void SpawnShapes()
{
    for (int i = 0; i < randomShapes.Length; i++)
    {
        randomShapes[i] = Shape.GenerateShape();
    }

}

void SeeShapes(Shape[] shapes)
{
    foreach(Shape shape in shapes)
    {
        sumArea += shape.Area;
        
        
        if (shape is Circle)
        {
            shapeCounter[0]++;
            
        }
        else if (shape is Rectangle)
        {
            
            if (!(shape as Rectangle).IsSquare)
            {
                shapeCounter[1]++;

            }
            else
            {
                shapeCounter[2]++;
            }

        }
        
        else if (shape is Triangle)
        {
            sumTrianglePerimeters += (shape as Triangle).Circumference;
            shapeCounter[3]++;

        }
        else if (shape is Cuboid)
        {
            if ((shape as Cuboid).Volume > largest3DShape.Volume)
            {
                largest3DShape = shape as Cuboid;
            }

            if (!(shape as Cuboid).IsCube)
            {
                shapeCounter[4]++;

            }
            else
            {
                shapeCounter[5]++;
            }

        }
        
        else if (shape is Sphere)
        {
            if ((shape as Sphere).Volume > largest3DShape.Volume)
            {
                largest3DShape = shape as Sphere;
            }
            shapeCounter[6]++;

        }
    }
}

void ShowShapes()
{
    for (int i = 0; i < randomShapes.Length; i++)
    {
        Console.WriteLine(randomShapes[i].ToString());
        Console.WriteLine();
    }

    Console.WriteLine(MostCommon(shapeCounter));

    Console.WriteLine(MeanArea(sumArea, randomShapes.Length));


    if (sumTrianglePerimeters != 0)
    {
        Console.WriteLine($"The sum of all triangular perimeters is {sumTrianglePerimeters}.");

    }
    else
    {
        Console.WriteLine("There are no triangles in the array.");
    }

    if (largest3DShape.Volume != 0)
    {
        Console.WriteLine($"The 3D shape with the most volume is {largest3DShape}.");

    }
    else
    {
        Console.WriteLine("There are no 3D shapes in the array.");
    }
}
        
        
        
        
        



string MostCommon(int[] arr)
{
    string[] shapeNames = new string[] { "circles", "rectangles", "squares", "triangles", "cuboids", "cubes", "spheres"};
    List<string> chosenShapes = new List<string>();
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == arr.Max())
        {
            chosenShapes.Add(shapeNames[i]);
            
        }
    }

    string chosenToString = string.Join(" and ", chosenShapes);

    return $"The most common shapes are {chosenToString}, with {arr.Max()} instances.";
}

string MeanArea(float sum, int summands)
{
    float mean = sum / (float)summands;
    return $"The mean area of all shapes in the array is {mean}.";
}

























