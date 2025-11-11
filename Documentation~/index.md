# Sawyer AI Documentation

Welcome to Sawyer AI, your intelligent Unity development assistant.

## Table of Contents

- [Getting Started](#getting-started)
- [Features](#features)
- [API Reference](#api-reference)
- [Examples](#examples)
- [Troubleshooting](#troubleshooting)

## Getting Started

### Installation

1. Open Unity Package Manager (`Window > Package Manager`)
2. Add the Sawyer AI package
3. Access the tool via `Window > Sawyer AI`

### First Steps

1. **Configure Settings**: Open the Sawyer AI settings panel and configure your preferences
2. **Test Connection**: Verify the Python backend connection is working
3. **Generate Your First Script**: Use natural language to create a Unity component

## Features

### AI Code Generation
- Generate Unity scripts from natural language descriptions
- Create components, MonoBehaviours, and ScriptableObjects
- Automatic using statement management
- Context-aware code suggestions

### Project Analysis
- Automatic project structure detection
- Asset dependency analysis
- Code quality suggestions
- Performance optimization recommendations

### Workflow Automation
- Automated file organization
- Batch operations on assets
- Custom code templates
- Integration with version control

## API Reference

### Core Classes

#### `SawyerAI`
Main entry point for Sawyer AI functionality.

```csharp
public class SawyerAI
{
    public static void GenerateScript(string description);
    public static void AnalyzeProject();
    public static bool IsConnected { get; }
}
```

#### `CodeGenerator`
Handles AI-powered code generation.

```csharp
public class CodeGenerator
{
    public Task<string> GenerateAsync(string prompt);
    public void SetTemplate(CodeTemplate template);
}
```

## Examples

### Basic Script Generation

```csharp
// Generate a player controller
SawyerAI.GenerateScript("Create a player controller with WASD movement and jump");
```

### Project Analysis

```csharp
// Analyze current project structure
var analysis = SawyerAI.AnalyzeProject();
Debug.Log($"Found {analysis.ScriptCount} scripts");
```

## Troubleshooting

### Common Issues

**Python Connection Failed**
- Ensure Python backend is running
- Check firewall settings
- Verify port configuration

**Code Generation Not Working**
- Check API key configuration
- Verify internet connection
- Check Python backend logs

### Support

For additional help:
- Check our [FAQ](https://docs.unakin.com/faq)
- Join our [Discord](https://discord.gg/unakin)
- Contact support@unakin.com