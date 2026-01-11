AR Image Recognition App
Overview
An Android-based Augmented Reality (AR) application that detects predefined image targets and plays associated video content in real time. The app is designed for seminars, conferences, events, and classrooms to enhance explanations through interactive visual content.

________________________________________
Key Functionality
•	Detects predefined image targets using the device camera
•	Tracks image targets in real time
•	Plays linked video content when an image is recognized
•	Maintains stable tracking across varying lighting conditions
________________________________________
Project Structure (Key Files)
•	AR_track.sln – Unity solution file for the AR project
•	VideoPlayerScript.cs – Handles video playback when an image target is detected
•	XRSimulationRuntimeSettings.asset – XR and AR runtime configuration
•	projectResolution.json – Display and resolution settings
•	Starter Assets / AR Starter Assets – Unity AR starter configurations
•	one.jpg – Sample image target used for recognition
________________________________________
How It Works
1.	The camera scans the environment for predefined image targets
2.	When a target image is detected, tracking is initialized
3.	VideoPlayerScript.cs triggers the associated video playback
4.	The video remains aligned with the image as long as it stays in view
________________________________________
Setup & Run Instructions
1.	Open the project in Unity Hub
2.	Load the solution using AR_track.sln
3.	Ensure required AR packages are installed (AR Foundation / XR plugins)
4.	Configure the image target using the provided sample image (one.jpg)
5.	Attach VideoPlayerScript.cs to the image target object
6.	Build and deploy the project to an Android device
7.	Launch the app and scan the predefined image to trigger video playback
________________________________________
Use Cases
•	Classroom demonstrations and visual learning
•	Interactive explanations during seminars and conferences
•	Event-based presentations and immersive storytelling
________________________________________
Notes
This repository represents a functional AR prototype focused on image-based recognition and video interaction. The project can be extended with additional image targets, videos, analytics, or user interaction features.
