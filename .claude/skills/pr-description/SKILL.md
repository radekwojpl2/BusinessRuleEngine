---
name: pr-description
description: Use when opening or updating a pull request and the user wants a PR title and description written from the branch's commits and diff.
license: MIT
---

# PR Description

## Steps
1. Find the base branch (usually `main`) and run `git log --oneline <base>..HEAD` and `git diff <base>...HEAD --stat`.
2. Read the relevant parts of the diff to understand the intent of the change.
3. Write a title under 70 characters that says what the PR does.
4. Fill in the template below. Leave out sections that do not apply.

## Template
```markdown
## Summary
<1-3 sentences: what changes and why>

## Changes
- <notable change>
- <notable change>

## How to test
1. <step>
2. <expected result>

## Notes
<breaking changes, migrations, follow-ups, screenshots>
```

## Conventions
- Describe behaviour, not files; reviewers can read the file list themselves.
- Link the issue (`Closes #123`) when there is one.
- Call out risky areas, breaking changes and required config or migrations explicitly.
- Do not invent test steps you have not verified; say what was and was not tested.
