using ScottPlot.Colormaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Kozelites
{
    public class PointInserter
    {
        private readonly Random _rand;
        private readonly InsertFunction _insertFunction;
        private readonly BindingList<Pont2D> _pontok;
        private readonly Action<float, float> _addPont;
        private readonly int _maxIter;

        public PointInserter(Random random, InsertFunction insertFunction, BindingList<Pont2D> pontok, Action<float, float> addPont, int maxIter)
        {
            _rand = random;
            _insertFunction = insertFunction;
            _pontok = pontok;
            _addPont = addPont;
            _maxIter = maxIter;
        }

        private float CalculateNoise(bool isNoiseEnabled)
        {
            return isNoiseEnabled ? (float)(_insertFunction.trackBar1.Value * _rand.NextDouble()) : 1;
        }

        public void GenerateScatterPoints()
        {
            for (int i = 0; i < _maxIter; i++)
            {
                _addPont(_rand.Next(-10, 10), _rand.Next(-10, 10));
            }
        }

        public void GenerateAbsPoints(bool isNoiseEnabled)
        {
            float noise;
            for (int i = _maxIter; i > -1; i--)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(-i + noise, i + noise);

                if (i != 0) // Nullát csak egyszer rajzoljuk
                {
                    _addPont(Math.Abs(-i * noise), Math.Abs(i * noise));
                }
            }
        }

        public void GenerateLogPoints(bool isNoiseEnabled)
        {
            float noise;
            for (int i = 1; i < _maxIter; i++)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(i, (float)Math.Log(i * noise));
            }
        }

        public void GenerateExpPoints(bool isNoiseEnabled)
        {
            float noise;
            for (int i = 1; i < _maxIter; i++)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(i, (float)Math.Exp(i * noise));
            }
        }

        public void GeneratePowPoints(float fokszam, bool isNoiseEnabled)
        {
            float noise;
            for (int i = -_maxIter; i < _maxIter + 1; i++)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(i, (float)Math.Pow(i * noise, fokszam));
            }
        }

        public void GenerateQuotientPoints(bool isNoiseEnabled)
        {
            float noise;
            for (int i = 1; i < _maxIter; i++)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(i, (float)1 / i * noise);
            }
        }

        public void GenerateSqrtPoints(bool isNoiseEnabled)
        {
            float noise;
            for (int i = 0; i < _maxIter; i++)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(i, (float)Math.Sqrt(i * noise));
            }
        }

        public void GenerateSinPoints(bool isNoiseEnabled)
        {
            float noise;
            for (int i = 0; i < _maxIter; i++)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(i, (float)Math.Sin(i * noise));
            }
        }

        public void GenerateCosPoints(bool isNoiseEnabled)
        {
            float noise;
            for (int i = 0; i < _maxIter; i++)
            {
                noise = CalculateNoise(isNoiseEnabled);
                _addPont(i, (float)Math.Cos(i * noise));
            }
        }
    }
}
