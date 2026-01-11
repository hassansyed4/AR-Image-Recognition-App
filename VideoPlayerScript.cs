    using NUnit.Framework;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Video;
    using UnityEngine.XR.ARFoundation;


    public class VideoPlayerScript : MonoBehaviour
    {
        public ARTrackedImageManager trackedImageManager;
        public VideoPlayer videoPlayer;
        public List<VideoClip> videoClips;
        private Dictionary<string, VideoClip> imageToVideo = new Dictionary<string, VideoClip>();

        private void Awake()
        {
            for (int i = 0; i < trackedImageManager.referenceLibrary.count; i++)
            {
                var referenceImage = trackedImageManager.referenceLibrary[i];
                if (i < videoClips.Count)
                {
                    imageToVideo[referenceImage.name] = videoClips[i];
                }
            }
        }
        void OnEnable()
        {
            trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
        }

        private void OnDisable()
        {
            trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        }
        private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
        { 
            foreach (var trackedImage in eventArgs.added)
            {
                UpdateVideo(trackedImage);
            }

            foreach (var trackedImage in eventArgs.updated)
            {
                UpdateVideo(trackedImage);
            }
        }


        private void UpdateVideo(ARTrackedImage trackedImage)
        {
            if(imageToVideo.TryGetValue(trackedImage.referenceImage.name, out VideoClip clip))
            {
                videoPlayer.clip = clip;
                videoPlayer.Play();
            }
        }

    }
