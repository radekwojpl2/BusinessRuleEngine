---
name: conventional-commit
description: Use when writing or reviewing a git commit message. Produces messages in the Conventional Commits format (type(scope) subject, body, footer) based on the staged diff.
license: MIT
---

# Conventional Commit

## Steps
1. Run `git diff --staged` to see what is being committed. If nothing is staged, ask the user what to stage.
2. Pick one type: `feat`, `fix`, `docs`, `style`, `refactor`, `perf`, `test`, `build`, `ci`, `chore`.
3. Pick an optional scope: the module, package or folder most affected (e.g. `auth`, `api`).
4. Write the subject line: `type(scope): summary`.
5. If the change needs explanation, add a body after a blank line: what changed and why, not how.
6. Add footers when relevant: `BREAKING CHANGE: ...`, `Closes #123`.

## Conventions
- Subject in imperative mood ("add", not "added"), lower case, no trailing period, max 72 characters.
- Wrap the body at 72 characters.
- One logical change per commit; if the diff mixes unrelated changes, suggest splitting it.
- Mark breaking changes with `!` after the type/scope (e.g. `feat(api)!: ...`) and a `BREAKING CHANGE:` footer.

## Example
```
fix(auth): refresh token before it expires

The token was refreshed only after a 401, which caused one failed
request per hour. Refresh it 60 seconds before expiry instead.

Closes #42
```
