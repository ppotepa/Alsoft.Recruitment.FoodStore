@echo off
setlocal

:: Define paths to the projects
set "AppProjectPath=Alsoft.Recruitment.FoodStore.App"
set "UIProjectPath=Alsoft.Recruitment.FoodStore.UI"


:: Start the API  project
echo Starting the UI project...
start "" dotnet run --project %AppProjectPath%

:: Start the UI project
echo Starting the UI project...
start "" dotnet run --project %UIProjectPath%




