# Sawyer Package (Cross-Version Compatible)

## Unity Compatibility Layer Technology
This package uses **runtime reflection** to adapt to different Unity versions automatically.

## Current Build Information
- **Built with:** Unity 6000.0.44f1
- **Build Date:** 2025-11-11 16:57:52
- **Compatibility:** Unity 2022.x, 2023.3+, 6.x+

## Supported Unity Versions
✅ Unity 2022.x LTS  
✅ Unity 2023.3+ LTS  
✅ Unity 6.x+  
✅ Future versions (automatic fallbacks)  

## How It Works
1. **Runtime Detection**: Detects your Unity version at startup
2. **API Adaptation**: Uses reflection to call appropriate APIs
3. **Automatic Fallbacks**: Handles missing APIs gracefully
4. **Performance Optimization**: Caches API availability

## Installation
1. Copy this folder to your `Assets/` directory
2. Unity will compile automatically
3. Check Console for compatibility layer logs

## API Compatibility Handled
- UI Elements: `iconImage` ↔ `backgroundImage`
- Physics: `linearVelocity` ↔ `velocity`  
- JSON: Namespace differences handled automatically
- Text: `PreWrap` ↔ `Normal` wrapping modes

Built with Unity Compatibility Layer v1.0 🚀
