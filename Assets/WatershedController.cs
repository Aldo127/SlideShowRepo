//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class WatershedController : MonoBehaviour
//{
//    [SerializeField]
//    private float springStiffness = 0.1f;
//    [SerializeField]
//     private List<WaterSpring> springs = new();

//    public float spread = 0.006f;

//    private int CornersCount = 2;
//    [SerializeField]
//    private SpriteShapeController spriteShapeController;
//    [SerializeField]
//    private int WavesCount = 6;
//    private void SetWaves()
//    {
//        Spline waterSpline = spriteShapeController.spline;
//        int waterPointsCount = waterSpline.GetPointCount();

//        for (int i = CornersCount; i < waterPointsCount - CornersCount; i++)
//        {
//            waterSpline.RemovePointAt(CornersCount);
//        }

//        Vector3 waterTopLeftCorner = waterSpline.GetPosition(1);
//        Vector3 waterTopRightCorner = waterSpline.GetPosition(2);
//        float waterWidth = waterTopRightCorner.x - waterTopLeftCorner.x;

//        float spacingPerWave = waterWidth / (WavesCount + 1);

//        for (int i = WavesCount; i > 0; i--)
//        {
//            int index = CornersCount;
//            float xPosition = waterTopLeftCorner.x + (spacingPerWave * i);
//            Vector3 wavePoint = new Vector3(xPosition, waterTopLeftCorner.y, waterTopLeftCorner.z);
//            waterSpline.InsertPointAt(index, 0.1f);
//            waterSpline.SetHeight(index, 0.1f);
//            waterSpline.SetCorner(index, false);

//        }
//    }

//    private void CreateSprings(Spline waterSpline)
//    {
//        springs = new();
//        for (int i = 0; i <= WavesCount+1; i++)
//        {
//            int index = i + 1;
//            GameObject wavePoint = Instantiate(wavePointPref, wavePoints.transform, false);
//            ////////WaterSpring waterspring = wavePoint.GetComponent<WaterSpring>(); 
//        }
//    }

//     void FixedUpdate()
//    {
//    //    foreach(waterspring waterSpringComponent in springs)
//        {
//     //       waterSpringComponent.WaveSpringUpdate(springStiffness);
//        }

//        UpdateSprings();
//    }
    
//    private void UpdateSprings()
//    {
//        int count = springs.Count;
//        float[] left_deltas = new float[count];
//        float[] right_deltas = new float[count];
//        for(int i = 0; i < count; i++)
//        {
//            if (i > 0)
//            {
//                left_deltas[i] = spread * (springs[i].height - springs[i - 1].height);
//                springs[i - 1].velocity += left_deltas[i];
//            }
//            if (i < springs.Count - 1)
//            {
//                right_deltas[i] = spread * (springs[1].height - springs[i + 1].height);
//                springs[i + 1].Velocity += right_deltas[1];
//            }
//        }
//    }

//    private void Splash(int index, float speed)
//    {
//        if (index >= 0 && index < springs.Count)
//        {
//            springs[index].velocity += speed;
//        }
//    }
//}
