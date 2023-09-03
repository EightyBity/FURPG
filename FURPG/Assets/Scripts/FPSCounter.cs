using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//OG author of this FPS counter https://gist.github.com/st4rdog/80057b406bfd00f44c8ec8796a071a13
 
public class FPSCounter : MonoBehaviour
{
    
    public Text Text;
 
    private Dictionary<int, string> CachedNumberStrings = new();
    private int[] _frameRateSamples;
    private int _cacheNumbersAmount = 300;
    private int _averageFromAmount = 30;
    private int _averageCounter = 0;
    private int _currentAveraged;
 
    void Awake()
    {
        // Cache strings and create array
        {
            for (int i = 0; i < _cacheNumbersAmount; i++) {
                CachedNumberStrings[i] = i.ToString();
            }
            _frameRateSamples = new int[_averageFromAmount];
        }
        Application.targetFrameRate = -1;
    }
    void Update()
    {
        // Sample
        {
            var currentFrame = (int)Math.Round(1f / Time.smoothDeltaTime); // If your game modifies Time.timeScale, use unscaledDeltaTime and smooth manually (or not).
            _frameRateSamples[_averageCounter] = currentFrame;
        }
 
        // Average
        {
            var average = 0f;
 
            foreach (var frameRate in _frameRateSamples) {
                average += frameRate;
            }
 
            _currentAveraged = (int)Math.Round(average / _averageFromAmount);
            _averageCounter = (_averageCounter + 1) % _averageFromAmount;
        }
 
        // Assign to UI
        {
            Text.text = _currentAveraged switch
            {
                var x when x < _cacheNumbersAmount && x > 0 => CachedNumberStrings[x],
                var x when x < 0 => "< 0",
                var x when x > _cacheNumbersAmount => $"> {_cacheNumbersAmount}"
            };
        }
    }
}