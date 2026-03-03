@echo off
echo ========================================
echo Unity Package Reset - Complete Fix
echo ========================================
echo.
echo This will:
echo 1. Delete Library folder
echo 2. Delete PackageCache
echo 3. Force Unity to re-download all packages
echo.
echo CLOSE UNITY FIRST!
echo.
pause

echo.
echo Step 1: Deleting Library folder...
if exist "Library" (
    rd /s /q "Library"
    echo Library deleted.
) else (
    echo Library folder not found.
)

echo.
echo Step 2: Deleting Temp folder...
if exist "Temp" (
    rd /s /q "Temp"
    echo Temp deleted.
) else (
    echo Temp folder not found.
)

echo.
echo Step 3: Deleting obj folder...
if exist "obj" (
    rd /s /q "obj"
    echo obj deleted.
) else (
    echo obj folder not found.
)

echo.
echo ========================================
echo Done! Now:
echo 1. Open Unity
echo 2. Wait for packages to re-download
echo 3. Errors should be gone
echo ========================================
echo.
pause
