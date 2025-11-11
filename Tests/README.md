# SawyerAI Package Testing Guide

## Overview
This directory contains unit tests for the SawyerAI package to ensure proper functionality and integration with Unity Editor.

## Test Structure
- `SawyerAIPackageTests.cs` - Basic package validation tests
- Additional test files can be added as needed

## Running Tests
1. Open Unity Test Runner (Window > General > Test Runner)
2. Switch to EditMode tab
3. Run tests in the "com.unakin.sawyer-ai.Editor.Tests" assembly

## Test Categories

### Package Validation Tests
- Assembly loading verification
- Python platform directory existence
- Core server script validation
- Package Manager registration

## Adding New Tests
When adding new test files:
1. Place them in the `Tests/Editor` directory
2. Include the namespace `Unakin.SawyerAI.Editor.Tests`
3. Use NUnit framework attributes (`[Test]`, `[TestCase]`, etc.)
4. Follow Unity test best practices

## Dependencies
Tests require:
- Unity Test Framework
- NUnit Framework
- SawyerAI Editor assembly reference