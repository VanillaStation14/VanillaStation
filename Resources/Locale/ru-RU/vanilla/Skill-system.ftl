Skill-issue-message-medicine-unskilled = Требуется { $lvl } ур. медицины
Skill-issue-message-piloting-unskilled =  Требуется { $lvl } ур. пилотирования
Skill-issue-message-chemistry-unskilled =  Требуется { $lvl } ур. химии 
Skill-issue-message-rangeweapon-unskilled = Требуется { $lvl } ур. стрельбы
Skill-issue-message-research-unskilled = Требуется { $lvl } ур. исследования
Skill-issue-message-instrumentation-unskilled = Требуется { $lvl } ур. приборостроения
Skill-issue-message-building-unskilled = Требуется { $lvl } ур. строительства
Skill-issue-message-engineering-unskilled = Требуется { $lvl } ур. инженерии

shared-solution-container-component-on-examine-main-text-skill-issue = { "" }

Skill-train-overtrain-medicine = Ваш навык медицины больше, чем может дать эта книга.
Skill-train-overtrain-chemistry = Ваш навык химии больше, чем может дать эта книга.
Skill-train-overtrain-rangeweapon = Ваш навык стрельбы больше, чем может дать эта книга.
Skill-train-overtrain-piloting = Ваш навык пилотирования больше, чем может дать эта книга.
Skill-train-overtrain-research = Ваш навык исследований больше, чем может дать эта книга.
Skill-train-overtrain-instrumentation = Ваш навык приборостроения больше, чем может дать эта книга.
Skill-train-overtrain-building = Ваш навык строительства больше, чем может дать эта книга.
Skill-train-overtrain-engineering = Ваш навык инженерии больше, чем может дать эта книга.

ui-vote-type-ezmode = Дополнительные очки навыков
ui-vote-ezmode-title = Голосование за выдачу дополнительных очков навыков
ui-vote-ezmode-succeeded = NanoTrasen отправили на данную станцию настоящих мастероов на все руки! Все получили 36 очков навыков. Главы получили все навыки.
ui-vote-ezmode-failed = Голосование отклонено.
ui-vote-ezmode-yes = Да
ui-vote-ezmode-no = Нет
ui-vote-ezmode-fail-not-enough-players = Голосование о дополнительных очках навыков отклонено: Должно быть не больше { $PlayerRequirement } игроков.
ui-vote-ezmode-already-conducted = Голосование уже было проведено в этом раунде.

examine-skilltrainer-part-1 = Повышает навык [color={$skilltype ->
    [Piloting]#85490c
    [RangeWeapon]#8f2121
    [MeleeWeapon]#8f2121
    [Medicine]#005b53
    [Chemistry]#AD4915
    [Engineering]#AF8D1A
    [Building]#FFBF00
    [Research]#7c0183
    [Instrumentation]#4e0163
    *[other]white
}]{$skilltype ->
    [Piloting]пилотирования
    [RangeWeapon]стрельбы
    [MeleeWeapon]ближнего боя
    [Medicine]медицины
    [Chemistry]химии
    [Engineering]инженерии
    [Building]строительства
    [Research]исследований
    [Instrumentation]приборостроения
    *[other]???
}[/color].
examine-skilltrainer-part-2 = доступно {$SkillExpToLearn} опыта.