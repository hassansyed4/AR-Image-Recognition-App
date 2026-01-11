AR Image Recognition App
Overview

An Android-based Augmented Reality (AR) application that detects predefined image targets and plays associated video content in real time. The app is designed for seminars, conferences, events, and classrooms to enhance explanations through interactive visual content.

Key Functionality

Detects predefined image targets using the device camera

Tracks image targets in real time

Plays linked video content when an image is recognized

Maintains stable tracking across varying lighting conditions

Project Structure (Key Files)

AR_track.sln – Unity solution file for the AR project

VideoPlayerScript.cs – Handles video playback when an image target is detected

XRSimulationRuntimeSettings.asset – XR and AR runtime configuration

projectResolution.json – Display and resolution settings

Starter Assets / AR Starter Assets – Unity AR starter configurations

one.jpg – Sample image target used for recognition

How It Works

The camera scans the environment for predefined image targets

When a target image is detected, tracking is initialized

VideoPlayerScript.cs triggers the associated video playback

The video remains aligned with the image as long as it stays in view

Setup & Run Instructions

Open the project in Unity Hub

Load the solution using AR_track.sln

Ensure required AR packages are installed (AR Foundation / XR plugins)

Configure the image target using the provided sample image (one.jpg)

Attach VideoPlayerScript.cs to the image target object

Build and deploy the project to an Android device

Launch the app and scan the predefined image to trigger video playback

Use Cases

Classroom demonstrations and visual learning

Interactive explanations during seminars and conferences

Event-based presentations and immersive storytelling

Notes

This repository represents a functional AR prototype focused on image-based recognition and video interaction. The project can be extended with additional image targets, videos, analytics, or user interaction features.
