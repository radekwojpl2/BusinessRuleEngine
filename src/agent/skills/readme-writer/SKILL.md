---
name: readme-writer
description: Use when creating or rewriting a README.md for a project. Inspects
  the repository and writes a concise README with purpose, install, usage and
  development sections.
license: MIT
---
# README Writer

## Steps
1. Inspect the project: manifest files (`package.json`, `*.csproj`, `pyproject.toml`, `go.mod`), entry points, scripts, existing docs and the license.
2. Work out what the project does, who it is for, and how it is installed and run.
3. Write the README using the structure below. Only include commands you found in the repo.
4. If an existing README exists, keep accurate content and links; fix outdated parts.

## Structure
```markdown
# <Project name>

<One-sentence description of what it does.>

## Installation
<commands>

## Usage
<the shortest working example>

## Development
<build, test and lint commands>

## License
<license name>
```

## Conventions
- Lead with what the project does; skip badges and filler unless asked.
- Every command must be copy-pasteable and come from the repo (scripts, Makefile, CI config).
- Keep it short; link to longer docs instead of inlining them.
