@echo off
echo ========================================
echo Unity Render Pipeline Error Fix
echo ========================================
echo.
echo IMPORTANT: Close Unity before running this!
echo.
pause
echo.
echo Deleting Library folder...
rd /s /q "Library"
echo.
echo Done! Now reopen Unity.
echo Unity will regenerate the Library folder and fix the shader error.
echo.
pause
